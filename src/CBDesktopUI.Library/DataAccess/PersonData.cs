using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CBDesktopUI.Library.DataAccess
{
    public class PersonData : IPersonData
    {
        public PersonDbModel Contact { get; set; }
        public List<PhoneDbModel> ContactPhones { get; set; }
        public List<AddressDbModel> ContactAddreesses { get; set; }

        public void SaveContact(PersonDbModel person, PersonDetailModel personModel)
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    var Id = sql.SaveDataInTransaction("dbo.spPerson_Insert", person);

                    person.Id = Convert.ToInt32(Id);

                    foreach (var item in personModel.Phones)
                    {
                        item.PersonID = person.Id;

                        sql.SaveDataInTransaction("dbo.spPhone_Insert", item);
                    }

                    foreach (var item in personModel.Addresses)
                    {
                        item.PersonID = person.Id;

                        sql.SaveDataInTransaction("dbo.spAddress_Insert", item);
                    }

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }
        }

        public void EditContact(PersonDbModel person, PersonDetailModel personModel)
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    sql.SaveDataInTransaction("dbo.spPerson_Update", person);

                    foreach (var item in personModel.Phones)
                    {
                        item.PersonID = person.Id;

                        sql.SaveDataInTransaction("dbo.spPhone_Update", item);
                    }

                    foreach (var item in personModel.Addresses)
                    {
                        item.PersonID = person.Id;

                        sql.SaveDataInTransaction("dbo.spAddress_Update", item);
                    }

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }
        }

        public List<PersonDbModel> GetContacts()
        {
            var sql = new SqlDataAccess();

            var output = sql.LoadData<PersonDbModel, dynamic>("spPerson_GetAll", new { });

            return output;
        }

        public (PersonDbModel, List<PhoneDbModel>, List<AddressDbModel>) GetContactById(int id)
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    Contact = sql.LoadDataInTransaction<PersonDbModel, dynamic>("spPerson_GetById",
                        new { Id = id }).FirstOrDefault();

                    ContactPhones = sql.LoadDataInTransaction<PhoneDbModel, dynamic>(
                        "spPhone_GetById", new { Id = id });

                    ContactAddreesses = sql.LoadDataInTransaction<AddressDbModel, dynamic>(
                       "spAddress_GetById", new { Id = id });

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }

            return (Contact, ContactPhones, ContactAddreesses);
        }

        public void DeleteContact(int id)
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    sql.SaveDataInTransaction("dbo.spAddress_Delete", new { Id = id });
                    sql.SaveDataInTransaction("dbo.spPhone_Delete", new { Id = id });
                    sql.SaveDataInTransaction("dbo.spPerson_Delete", new { Id = id });

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }
        }
    }
}

