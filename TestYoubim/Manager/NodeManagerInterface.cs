using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYoubim.Model;
namespace TestYoubim.Manager
{
    interface NodeManagerInterface
    {
        Node getById(Guid id);

        IList<Node> getAll();
        Node create(string idUser, string name, string versionFile);
        bool delete(Guid id);
        Node edit(Guid id, Node node);

    }
}
