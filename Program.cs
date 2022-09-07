using System.Net;
using System.Net.Sockets;
try{
    Console.WriteLine("Enter device/computer name: ");

    string computerName = new String(Console.ReadLine());

    IPAddress[] ipAddresses = Dns.GetHostAddresses(computerName);

    Console.WriteLine("IPv6: " + ipAddresses[0] + "\nIPv4: " + ipAddresses[1]);
    Console.ReadKey();
  }
  catch(SocketException){
    Console.WriteLine("No such host is known\n");
  }
  catch(Exception ex){
    Console.WriteLine("Unknown Error Occured");
    Console.WriteLine(ex.ToString());
  }