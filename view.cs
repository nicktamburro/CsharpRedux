@*
    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
*@
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
 <head>
     <meta name="viewport" content="width=device-width" />
     <title>Index</title>
 </head>
<body>
    <div>
        @ViewBag.Greeting World (from the view)
        <p>Y'all ready for this? Please verify.</p>
        //this, below, is a tag helper... we use this 
        //rather than hard-coding the urls for a tags
        <a asp-action="RsvpForm">RSVP Now</a>
    </div>
</body>
</html>