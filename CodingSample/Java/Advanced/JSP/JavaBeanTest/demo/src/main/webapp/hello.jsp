<jsp:useBean id="greeter" class="app.components.GreeterBean" scope="session"/>
<jsp:setProperty name="greeter" property="person" param="someone"/>
<jsp:setProperty name="greeter" property="period"/>
<html>
    <head>
        <title>demo-web-app</title>
    </head>
    <body>
        <h1>${greeter.greetingMessage}</h1>
        <p>
            <b>Number of Greetings: </b>${greeter.greetCount}
        </p>
        <form method="post">
            <p>
                <b>Person:</b>
                <input name="someone"/>
            </p>
            <p>
                <b>Period:</b>
                <select name="period">
                    <option>Morning</option>
                    <option>Night</option>
                    <option>Afternoon</option>
                    <option>Evening</option>
                </select>
            </p>
            <input type="submit" value="Greet"/>
        </form>
    </body>
</html>