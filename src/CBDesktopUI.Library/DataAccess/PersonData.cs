using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;
using System.Collections.Generic;

namespace CBDesktopUI.Library.DataAccess
{
    public class PersonData : IPersonData
    {
        public void SaveContact(PersonDbModel person, PersonDetailModel personModel)
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    var Id = sql.SaveDataInTransaction("dbo.spPerson_Insert", person);

                    person.Id = (int)Id;

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

        public List<PersonDbModel> GetContacts()
        {
            var sql = new SqlDataAccess();

            var output = sql.LoadData<PersonDbModel, dynamic>("spPerson_GetAll", new { });

            return output;
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

