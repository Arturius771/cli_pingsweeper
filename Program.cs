﻿using System.Net;

Console.WriteLine("Enter device/computer name: ");

string computerName = new String(Console.ReadLine());

IPAddress[] ipAddresses = Dns.GetHostAddresses(computerName);

Console.WriteLine("IPv6: " + ipAddresses[0] + "\nIPv4: " + ipAddresses[1]);

Console.ReadKey();