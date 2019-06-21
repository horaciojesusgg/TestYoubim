using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYoubim.Model;
namespace TestYoubim.Manager
{
    interface NodeManagerInterface
    {
        Node GetById(Guid id);

        IList<Node> GetAll();
        Node Create(string idUser, string name, string versionFile);
        bool Delete(Guid id);
        Node Edit(Guid id, Node node);

    }
}
