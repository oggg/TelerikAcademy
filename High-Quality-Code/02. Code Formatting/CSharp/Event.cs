namespace CodeFormatting
{
	using System;
	using System.Text;
	
	public class Event : IComparable
	{
		public DateTime date;
		public String title;
		public String location;

		public Event(DateTime date, String title, String location)
		{
			this.date = date;
			this.title = title;
			this.location = location;
		}

		public int CompareTo(object obj)
		{
			Event newEvent = obj as Event;
			int byDate = this.date.CompareTo(obj.date);
			int byTitle = this.title.CompareTo(obj.title);
			int byLocation = this.location.CompareTo(obj.location);

			if (byDate == 0)
			{
				if (byTitle == 0)
				{
					return byLocation;
				}
				else
				{
					return byTitle;
				}
			}
			else
			{
				return byDate;
			}
		}

		public override string ToString()
		{
			StringBuilder printing = new StringBuilder();
			printing.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
			printing.Append(" | " + title);
			if (this.location != null && this.location != "")
			{
				printing.Append(" | " + location);
			}

			return printing.ToString();
		}
	}
}