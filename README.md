## DOCS
```csharp

//init client
TMail client = new TMailClient("https://urltmail.url", "APIKEY HERE");
 
 //gen new email
var email = await client.GenerateEmail();
 
//check
var emails = await client.CheckEmail(email); // Will return Waiting until emails arrive.
while (await client.CheckEmail(email) == "Waiting.")
{
	await Task.Delay(1000);
}

Console.WriteLine(emails);
```
