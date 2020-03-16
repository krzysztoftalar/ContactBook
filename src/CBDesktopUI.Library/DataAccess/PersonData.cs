using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CBDesktopUI.Library.DataAccess
{
    public class PersonData : IPersonData
    {
        private readonly ISqlDataAccess _sql;

        public PersonData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public PersonDbModel Contact { get; set; }
        public List<PhoneDbModel> ContactPhones { get; set; }
        public List<AddressDbModel> ContactAddreesses { get; set; }

        public void SaveContact(PersonDbModel person, PersonDetailModel personModel)
        {
            try
            {
                _sql.StartTransaction();

                var Id = _sql.SaveDataInTransaction("dbo.spPerson_Insert", person);

                person.Id = Convert.ToInt32(Id);

                foreach (var item in personModel.Phones)
                {
                    item.PersonID = person.Id;

                    _sql.SaveDataInTransaction("dbo.spPhone_Insert", item);
                }

                foreach (var item in personModel.Addresses)
                {
                    item.PersonID = person.Id;

                    _sql.SaveDataInTransaction("dbo.spAddress_Insert", item);
                }

                _sql.CommitTransaction();
            }
            catch
            {
                _sql.RollbackTransaction();
                throw;
            }

        }

        public void EditContact(PersonDbModel person, PersonDetailModel personModel)
        {
            try
            {
                _sql.StartTransaction();

                _sql.SaveDataInTransaction("dbo.spPerson_Update", person);

                foreach (var item in personModel.Phones)
                {
                    item.PersonID = person.Id;

                    _sql.SaveDataInTransaction("dbo.spPhone_Update", item);
                }

                foreach (var item in personModel.Addresses)
                {
                    item.PersonID = person.Id;

                    _sql.SaveDataInTransaction("dbo.spAddress_Update", item);
                }

                _sql.CommitTransaction();
            }
            catch
            {
                _sql.RollbackTransaction();
                throw;
            }
        }

        public List<PersonDbModel> GetContacts()
        {
            return _sql.LoadData<PersonDbModel, dynamic>("spPerson_GetAll", new { });
        }

        public (PersonDbModel, List<PhoneDbModel>, List<AddressDbModel>) GetContactById(int id)
        {
            try
            {
                _sql.StartTransaction();

                Contact = _sql.LoadDataInTransaction<PersonDbModel, dynamic>(
                    "spPerson_GetById", new { Id = id })
                    .FirstOrDefault();

                ContactPhones = _sql.LoadDataInTransaction<PhoneDbModel, dynamic>(
                    "spPhone_GetById", new { Id = id });

                ContactAddreesses = _sql.LoadDataInTransaction<AddressDbModel, dynamic>(
                   "spAddress_GetById", new { Id = id });

                _sql.CommitTransaction();
            }
            catch
            {
                _sql.RollbackTransaction();
                throw;
            }


            return (Contact, ContactPhones, ContactAddreesses);
        }

        public void DeleteContact(int id)
        {
            try
            {
                _sql.StartTransaction();

                _sql.SaveDataInTransaction("dbo.spAddress_Delete", new { Id = id });
                _sql.SaveDataInTransaction("dbo.spPhone_Delete", new { Id = id });
                _sql.SaveDataInTransaction("dbo.spPerson_Delete", new { Id = id });

                _sql.CommitTransaction();
            }
            catch
            {
                _sql.RollbackTransaction();
                throw;
            }
        }

        public void DeletePhone(int id)
        {
            _sql.SaveData("dbo.spPhone_Delete", new { Id = id });
        }

        public void DeleteAddress(int id)
        {
            _sql.SaveData("dbo.spAddress_Delete", new { Id = id });
        }
    }
}

