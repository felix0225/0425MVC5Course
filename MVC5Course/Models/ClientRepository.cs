using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;

namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
	    public override IQueryable<Client> All()
	    {
            return base.All().Where(c => !c.IsDelete).OrderBy(c => c.ClientId);
	    }

        internal IQueryable<Client> SearchByGender(string gender)
        {
            return this.All().Where(p => p.Gender == gender).Take(10);
        }
        internal IQueryable<Client> SearchByCity(string city)
        {
            if (string.IsNullOrEmpty(city))
                return this.All();
            else
                return this.All().Where(p => p.City == city);
        }
	    public Client Find(int? id)
	    {
	        return this.All().FirstOrDefault(c => c.ClientId == id.Value);
	    }

        //stored procedure
	    public ObjectResult<Product> QueryProducts()
	    {
	        return ((FabricsEntities) UnitOfWork.Context).QueryProduct();
	    }

	    public void Delete(Client client)
	    {
            //client.IsDelete = true;

            var db = ((FabricsEntities) UnitOfWork.Context);
	        foreach (var item in db.Order.ToList())
	        {
	            db.OrderLine.RemoveRange(item.OrderLine);
	        }
	        db.Order.RemoveRange(client.Order);

	    }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}