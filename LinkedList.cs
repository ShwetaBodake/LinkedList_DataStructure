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

		public int Search(int value)
		{
			Node node = this.head;
			int count = 0;
			while(node != null)
			{
				if(node.data==value)
				{
					return count;
				}
				node = node.next;
				count++;
			}
			return count;
		}

		public Node InsertParticularPosition(int Position,int Data)
		{
			if(Position<1)
			{
				Console.WriteLine("Invalid Position");
			}
			if(Position==1)
					{
				var newNode = new Node(Data);
				newNode.next = this.head;
				head = newNode;
			}
			else
			{
				while(Position-- !=0)
				{
					if(Position==1)
					{
						Node node = new Node(Data);
						node.next = this.head.next;
						head.next = node;
						break;
					}
					head = head.next;
				}
				if (Position != 1)
				{
					Console.WriteLine("Position Out Of Range ");
				}
				
			}
            return head;

        }
	}
}

