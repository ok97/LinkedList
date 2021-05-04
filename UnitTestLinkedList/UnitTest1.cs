using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedLists;
namespace UnitTestLinkedList
{
    
    [TestClass]/*TC1 Adding Element in Linked list*/
    public class UnitTest1
    {
        LinkedList list = new LinkedList(); //Create object of LinkedList class

        [TestMethod]
        public void AddElementLinkedList()
        {
            list.Add(56);
            list.Add(30);
            list.Add(70);
        }
    }
}
