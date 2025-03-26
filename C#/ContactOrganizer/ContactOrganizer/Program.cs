List<string> contacts = Console.ReadLine().Split().ToList();

string option = Console.ReadLine();

while (option != "end")
{
    string[] cmd = option.Split().ToArray();

    string command = cmd[0];

    switch (command)
    {
        case "Add":
            string contact = cmd[1];
            contacts.Add(contact);
            break;
        case "Remove":
            string nameToRemove = cmd[1];

            contacts.RemoveAll(c => c.Contains(nameToRemove));

            break;
        case "Update":
            string contactToAdd = cmd[1];

            if (contacts.Contains(contactToAdd))
            {
                int foundedIndex = contacts.IndexOf(contactToAdd);

                contacts.RemoveAt(foundedIndex);

                contacts.Insert(foundedIndex, contactToAdd);
            }
            else
            {
                contacts.Add(contactToAdd);
            }
            break;
    }

    option = Console.ReadLine();
}