@model ReteriveValue.Models.ReteriveDemoEntities  
@{  
   ViewBag.Title = "Index";  
}  
<h2>Reteriving Data From Database</h2>  
 <!DOCTYPE html>  
<html>  
<head>  
 <meta name="viewport" content="width=device-width" />  
<title>Index</title>  
<style type="text/css">  
table, td, th {  
 border: 1px solid green;  
}  
 th {  
        background-color: Pink;  
        color: white;  
     }  
    </style>  
    </head>  
    <body>  
    <table style="margin-left: 25%; margin-top: 10px; border: 2px solid LightGray;">  
     <tr>  
         <th>ID</th>  
         <th>Name</th>  
         <th>Appointment</th>  
         <th>Technology</th>  
         <th>Task</th>  
      </tr>  
   @foreach (var item in Model.infoes)  
   {  
       <tr>  
           <td>@item.ID</td>  
           <td>@item.Name<td>  
           <td>@item.Appointment<td>  
           <td>@item.Technology</td>  
           <td>@item.Task</td>  
        </tr>  
    }  
 </table>  
       </body>  
</html> 