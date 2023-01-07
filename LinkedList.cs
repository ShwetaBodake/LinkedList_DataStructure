using System;
namespace LinkedList
{
	public class LinkedList
	{
		public Node head;
		public void Add(int data)
		{
			Node node = new Node(data);
			if(this.head==null)
			{
				this.head = node;
			}
			else
			{
				Node temp = head;
				while(temp.next!=null)
				{
					temp = temp.next;
				}
				temp.next = node;
			}
			Console.WriteLine("{0} inserted into linked list", node.data);
		}


		public void toprint()
		{
			Node temp = this.head;
			if(temp==null)
			{
				Console.WriteLine("Linked List is empty");
				return;
			}
			while(temp!=null)
			{
				Console.Write(temp.data + " ");
				temp = temp.next;
			}
		}
	}
}

