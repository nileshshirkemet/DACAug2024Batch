<jsp:useBean id="now" class="java.util.Date" scope="page"/>
<html>
	<head>
		<title>demo-web-app</title>
	</head>
	<body>
		<h1>Welcome Visitor ${param.user}</h1>
		<b>Current Time: </b>${now}
	</body>
</html>

