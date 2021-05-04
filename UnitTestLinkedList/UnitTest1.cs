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

      [TestMethod] /*TC7*/
        
        [DataRow(01, 0)]
        public void SearchingElementInLinkedList(int data, int position)
        {
            
            //add
            int actual = list.Search(data);
            int expected = position;
            //assert
            Assert.AreEqual(actual, expected);

        }


[TestMethod] /*TC8*/
        [DataRow(16, 70)]
        public void InsertElementInLinkedList(int a, int b)
        {
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //values should be in same order, as program class, as while checking for inserting element
            list.InsertAtAfterValue(a, b);
            int expected = list.Search(a);
            int positionForSearchData = list.Search(b);
            int actual = positionForSearchData + 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
