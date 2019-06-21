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
        public Node GetById(Guid nodeId)
        {
            return this._nodeRepo.GetNodeById(nodeId);
        }

        public IList<Node> GetAll()
        {
            return this._nodeRepo.GetAllNodes();
        }

        public Node Create(string idUser, string name, string versionFile)
        {
            Node newNode = new Node();
            newNode.Id = Guid.NewGuid();
            newNode.IdUser = idUser;
            newNode.Name = name;
            newNode.VersionFile = versionFile;
            return this._nodeRepo.CreateNode(newNode);
        }

        public bool Delete(Guid id)
        {
            Node node = this.GetById(id);
            return this._nodeRepo.DeleteNode(node);
        }

        public Node Edit(Guid id, Node node)
        {
            return this._nodeRepo.EditNode(node); ;
        }
    }
}
