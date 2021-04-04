## DOCS
```csharp

//init client
TMail client = new TMailClient("https://urltmail.url", "APIKEY HERE");
 
 //order
var email = await client.GenerateEmail();
 
//check
emailwait:
var emails = await client.CheckEmail(email); // Will return Waiting. if still waiting it auto refund if expired
while (emails == "Waiting.")
{
	await Task.Delay(1000);
	goto emailwait; //wouldn't recommend using this but it works for newbs
}

Console.WriteLine(emails);

```
