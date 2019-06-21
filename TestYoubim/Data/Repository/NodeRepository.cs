using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYoubim.Data.Context;
using TestYoubim.Model;
using Microsoft.EntityFrameworkCore;

namespace TestYoubim.Data.Repository
{
    public class NodeRepository
    {
        private readonly CustomDbContext _nodeContext;
        public NodeRepository(CustomDbContext nodeContext)
        {
            _nodeContext = nodeContext;
        }

        public Node GetNodeById(Guid Id)
        {
            Node node = this._nodeContext.Node.First(p => p.Id.Equals(Id));
            return node;
        }

        public Node createNode(Node newNode)
        {
            try
            {
                this._nodeContext.Node.Add(newNode);
                this._nodeContext.SaveChanges();
                return newNode;
            } catch (Exception e)
            {
                throw new Exception("Error while new Node in the database.");
            }
        }

        public IList<Node> getAllNodes()
        {
            return this._nodeContext.Node.ToList();
        }

        public Node editNode(Node node)
        {
            this._nodeContext.Entry(node).State = EntityState.Modified;
            try
            {
                this._nodeContext.SaveChanges();
                return node;
            } catch (Exception e)
            {
                throw new Exception("Error while editing the node.");
            }
        }

        public bool deleteNode(Node node)
        {
            try {
                this._nodeContext.Node.Remove(node);
                this._nodeContext.SaveChanges();
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }
    }
}
