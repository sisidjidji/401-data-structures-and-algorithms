using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static Data_Structures.Graphs.Graphs;
using static Data_Structures.Graphs.Graphs.Graph<T>;

namespace Data_Structures_testing
{
    public class GraphTests
    {
        [Fact]
        public void can_return_empty_graph()
        {
            Graph<int> graphe = new Graph<int>();
            Assert.Null(graphe.GetNodes());
        }
        [Fact]

        public void can_add_node_one_node()
        {
            Graph<int> graphe = new Graph<int>();

            graphe.AddNode(2);

            Assert.Contains( 2 , graphe.GetNodes());
        }
        [Fact]
        public void can_add_multiple_nodes()
        {
            Graph<int> graphe = new Graph<int>();

            graphe.AddNode(2);
            graphe.AddNode(5);
            graphe.AddNode(7);
            graphe.AddNode(12);

            Assert.Contains(2, graphe.GetNodes());
            Assert.Contains(5, graphe.GetNodes());
            Assert.Contains(7, graphe.GetNodes());
            Assert.Contains(12, graphe.GetNodes());
            
        }

        [Fact]
        public void can_add_Edge()
        {
            Graph<int> graphe = new Graph<int>();

            graphe.AddNode(2);
            graphe.AddNode(5);

            bool result=graphe.AddEdge(2, 5);

            Assert.True(result);

        }

        [Fact]
         public void can_retreive_all_nodes()
        {
            List<int> list = new List<int> {7,5,6,9,2};
            Graph<int> graphe = new Graph<int>();

            graphe.AddNode(7);
            graphe.AddNode(5);
            graphe.AddNode(6);
            graphe.AddNode(9);
            graphe.AddNode(2);

            Assert.Equal(list, graphe.GetNodes());
           
        }

        [Fact]
        public void can_retreive_neighbors()
        {
            
            Graph<int> graphe = new Graph<int>();

            graphe.AddNode(7);
            graphe.AddNode(5);
            graphe.AddNode(6);
            graphe.AddNode(9);
            graphe.AddNode(2);

            graphe.AddEdge(7, 5);
            graphe.AddEdge(7, 9);
        


            Assert.Equal(2, graphe.GetNeighbors(7).Count);

        }

        [Fact]
        public void CorrectNumberOfNodesInAGraph()
        {

            Graph<int> graphe = new Graph<int>();

            graphe.AddNode(7);
            graphe.AddNode(5);
            graphe.AddNode(6);
            graphe.AddNode(9);
            graphe.AddNode(2);

            graphe.AddEdge(7, 5);
            graphe.AddEdge(7, 9);


            Assert.Equal(5, graphe.Size());
        }
        
    }
}
