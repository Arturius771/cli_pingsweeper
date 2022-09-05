using System.Net;
using System.Net.Sockets;

void DisplayData(){
  try{
      Console.WriteLine("Enter device/computer name: ");

      string computerName = new String(Console.ReadLine());

      IPAddress[] ipAddresses = Dns.GetHostAddresses(computerName);

      Console.WriteLine("IPv6: " + ipAddresses[0] + "\nIPv4: " + ipAddresses[1]);
      Console.ReadKey();
    }
    catch(SocketException){
      Console.WriteLine("No such host is known\nPress 'y' key to try again");
      if(Console.ReadKey().KeyChar == 'y'){
        Console.WriteLine();
        DisplayData();
      }
    }
}

DisplayData();