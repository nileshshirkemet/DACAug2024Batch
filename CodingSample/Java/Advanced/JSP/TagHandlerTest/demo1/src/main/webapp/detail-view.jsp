<%@ taglib uri="demo.app.tags" prefix="d" %>
<jsp:useBean id="login" class="app.components.LoginModelBean" scope="request"/>
<html>
    <head>
        <title>demo-web-app</title>
    </head>
    <body>
        <h1>Welcome Customer ${login.id}</h1>
        <h3>Your Orders</h3>
        <table border="1">
            <tr>
                <th>Product No</th>
                <th>Quantity</th>
                <th>Order Date</th>
            </tr>
            <d:fetchNextOrder customerId="${login.id}" orderVar="entry">
                <tr>
                    <td>${entry.productNo}</td>
                    <td>${entry.quantity}</td>
                    <td>${entry.orderDate}</td>
                </tr>
            </d:fetchNextOrder>
        </table>
        <p>
            <a href="/">Logout</a>
        </p>
    </body>
</html>