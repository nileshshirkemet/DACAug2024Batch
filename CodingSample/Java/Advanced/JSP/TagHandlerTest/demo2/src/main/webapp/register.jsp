<%@ taglib uri="jakarta.tags.core" prefix="c" %>
<jsp:useBean id="site" class="app.tourism.models.SiteModel" scope="application"/>
<html>
    <head>
        <title>demo-web-app</title>
    </head>
    <body>
        <h1>Welcome Visitor</h1>
        <h3>Register Visit</h3>
        <form method="post">
            <p>
                <b>Your Name:</b>
                <input type="text" name="visitorId" required="required"/>
            </p>
            <p>
                <b>Experience:</b>
                <select name="visitorRating">
                    <option value="5">Fantastic</option>
                    <option value="4">Fine</option>
                    <option value="3">Average</option>
                    <option value="2">Poor</option>
                    <option value="1">Pathetic</option>
                </select>
            </p>
            <p>
                <input type="submit" value="Submit"/>
            </p>
        </form>
        <p>
            <a href="welcome.jsp">Our Visitors</a>
        </p>
        <c:if test="${site.acceptVisit(param.visitorId, param.visitorRating)}">
            <c:redirect url="welcome.jsp"/>
        </c:if>
    </body>
</html>