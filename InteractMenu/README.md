### ENGLISH

To use this NuGet package just call the desired function.
For the moment there is only one function, list of choices, with only one possible output result.

Example of use :

```
{
    using InteractMenu;
    class Class1
    {
        private static void Main()
        {
            var menu = new ListMenu();
            var title = "Please make a choice :"
            var liste = new List<string> { "Choice 1", "Choice 2" };
            
            menu.AddListString(liste);
            
            var answer = menu.Ask(titre);
            Console.WriteLine(answer);
        }
    }
}
```
---
FRANCAIS

Pour utiliser ce paquet NuGet il suffit d'appeler la fonction désirer.
Pour le moment il n'y qu'une fonction, liste de choix, avec un seul résultat de sorti possible.

Exemple d’utilisation :
````
{
    using InteractMenu;
    class Class1
    {
        private static void Main()
        {
            var menu = new ListMenu();
            var titre = "Veuillez faire un choix :"
            var liste = new List<string> { "Choix 1", "Choix 2" };
            
            menu.AddListString(liste);
            
            var reponse = menu.Ask(titre);
            Console.WriteLine(reponse);
        }
    }
}
````