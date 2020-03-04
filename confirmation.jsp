<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <link rel="stylesheet" href="css/styles.css" type="text/css"/>
    </head>
    <body>
        <h1>Join our book store</h1>
        <p><i>${message}</i></p>
        <form action="registration" method="post">
            <input type="hidden" name="action" value="add">
            
            <label>First name:</label>
            <input type="text" name="firstName" value="${customer.firstName}" required ><br>
            
            <label>Last name:</label>
            <input type="text" name="lastName" value="${customer.lastName}"  required ><br>
            
            <label>Email:</label>
            <input type="email" name="email" value="${customer.email}" required ><br>
            
            <label>Address:</label>
            <input type="text" name="address" value="${customer.address}" required  ><br>
            
            <label>City:</label>
            <input type="text" name="city" value="${customer.city}"  required ><br>
            
            <label>State:</label>
            <input type="text" name="state" value="${customer.state}"required  ><br>
            
            <label>Zip:</label>
            <input type="text" name="zip" value="${customer.zip}" required ><br>
            
            <label>Country:</label>
            <input type="text" name="country" value="${customer.country}" required ><br>
            
            <label>&nbsp;</label>
            <input type="submit" value="Join Now" >
        </form>
     </body>
    </html>
