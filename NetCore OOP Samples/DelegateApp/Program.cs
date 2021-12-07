// See https://aka.ms/new-console-template for more information


void GetFullName1(string name, string surName)
{
    Console.WriteLine(name + " -1- " + surName);
}

void GetFullName2(string name, string surName)
{
    Console.WriteLine(name + " -2-" + surName);
}

void GetFullName3(string name, string surName)
{
    Console.WriteLine(surName + " -3-" + name);
}


FullNameDelegate fullName = new FullNameDelegate(GetFullName1);
fullName("burak", "unal");

FullNameDelegate fullname2 = new FullNameDelegate(GetFullName2);
fullname2("burak2", "unal2");

FullNameDelegate fullname3 = new FullNameDelegate(GetFullName3); // single cast delegate
fullname3("burak3", "unal3");

FullNameDelegate fullnamechain = fullName + fullname2 + fullname3; // multicast delegate
fullnamechain("burakchain", "unalchain");

public delegate void FullNameDelegate(string name, string surName);

