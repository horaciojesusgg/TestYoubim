using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYoubim.Data.Repository;
using TestYoubim.Model;

namespace TestYoubim.Manager
{
    public class NodeManager: NodeManagerInterface
    {
        private readonly NodeRepository _nodeRepo;
        public NodeManager(NodeRepository nodeRepo)
        {
            this._nodeRepo = nodeRepo;
        }
        public Node getById(Guid nodeId)
        {
            return this._nodeRepo.GetNodeById(nodeId);
        }

        public IList<Node> getAll()
        {
            return this._nodeRepo.getAllNodes();
        }

        public Node create(string idUser, string name, string versionFile)
        {
            Node newNode = new Node();
            newNode.Id = Guid.NewGuid();
            newNode.IdUser = idUser;
            newNode.Name = name;
            newNode.VersionFile = versionFile;
            return this._nodeRepo.createNode(newNode);
        }

        public bool delete(Guid id)
        {
            Node node = this.getById(id);
            return this._nodeRepo.deleteNode(node);
        }

        public Node edit(Guid id, Node node)
        {
            return this._nodeRepo.editNode(node); ;
        }
    }
}
