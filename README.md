## DOCS
```csharp

//init client
TMail client = new TMailClient("https://urltmail.url", "APIKEY HERE");
 
 //gen new email
var email = await client.GenerateEmail();
 
//check
emailwait:
var emails = await client.CheckEmail(email); // Will return Waiting until emails arrive.
while (emails == "Waiting.")
{
	await Task.Delay(1000);
	goto emailwait; //wouldn't recommend using this but it works for newbs
}

Console.WriteLine(emails);

```
