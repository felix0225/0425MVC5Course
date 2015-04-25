using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
	    public override IQueryable<Client> All()
	    {
	        return base.All().Where(c => !c.IsDelete);
	    }

	    public Client Find(int? id)
	    {
	        return this.All().FirstOrDefault(c => c.ClientId == id.Value);
	    }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}