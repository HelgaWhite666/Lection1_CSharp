Console.WriteLine ("Представьтесь, пожалуйста!");
string userName = Console.ReadLine();

if (userName.ToLower() == "ольга") {

    Console.WriteLine ("Ну привет, солнышко :)");

} else {

    Console.Write ("Здравствуйте, ");
    Console.Write (userName);
    Console.WriteLine ("!");

}