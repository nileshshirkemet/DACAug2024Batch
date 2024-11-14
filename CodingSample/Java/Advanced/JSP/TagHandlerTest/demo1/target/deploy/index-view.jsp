<%@ taglib uri="demo.app.tags" prefix="d" %>
<html>
	<head>
		<title>demo-web-app</title>
	</head>
	<body>
		<h1>Welcome Customer</h1>
		<h3>Please Sign In</h3>
		<form method="post">
			<p>
				<b>Customer ID</b><br/>
				<input type="text" name="customerId"/>
			</p>
			<p>
				<b>Password</b><br/>
				<input type="password" name="password"/>
			</p>
			<p>
				<input type="submit" value="Log In"/>
			</p>
		</form>
		<p>
			<i>${requestScope.problem}</i>
		</p>
		<hr/>
		<span>
			<d:putCurrentTime displayFormat="yyyy-MMM-dd HH:mm:ss"/>
		</span>
	</body>
</html>

