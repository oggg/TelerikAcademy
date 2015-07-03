namespace CodeFormatting
{
	using System;
	using System.Text;
	 
	public static class Messages
    {
        static StringBuilder output = new StringBuilder();

        public static void EventAdded()
        {
            output.Append("Event added");
            output.Append(Environment.NewLine);
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted", x);
                output.Append(Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found");
            output.Append(Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint);
                output.Append(Environment.NewLine);
            }
        }
    }
}