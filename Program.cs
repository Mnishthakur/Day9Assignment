namespace Day9Assignment;

    internal class Program
{
    static void Main(string[] args)
    {
        AddressBook addressBook = new AddressBook();

        // Adding contacts
        Contact contact1 = new Contact("Harry", "Parker", "harry.parker@example.com", "7891307074");
        Contact contact2 = new Contact("Sweetlana", "Johns", "johns.sweetlana@example.com", "9876543210");
        addressBook.AddContact(contact1);
        addressBook.AddContact(contact2);

        // Displaying contacts
        addressBook.DisplayContacts();

        // Removing a contact
        addressBook.RemoveContact(contact1);

        // Displaying contacts after removal
        addressBook.DisplayContacts();
    }
}
