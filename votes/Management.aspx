<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="votes.Management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
// Load google charts
google.charts.load('current', {'packages':['corechart']});
google.charts.setOnLoadCallback(drawChart);

// Draw the chart and set the chart values
function drawChart() {
  var data = google.visualization.arrayToDataTable([
  ['מפלגות', 'מנדטים'],
  ['העבודה-גשר',<%=Mandats[0]%>],
  ['יהדות התורה', <%=Mandats[1]%>],
  ['הרשימה המשותפת', <%=Mandats[2]%>],
  ['עוצמה כלכלית', <%=Mandats[3]%>],
  ['מפלגת הדמוקראטורה', <%=Mandats[4]%>],
  ['צומת', <%=Mandats[5]%>],
  ['ימין חדש', <%=Mandats[6]%>],
  ['מנהיגות חברתית', <%=Mandats[7]%>],
  ['אדום לבן', <%=Mandats[8]%>],
  ['התנועה הנוצרית הליברלית', <%=Mandats[9]%>],
  ['כבוד האדם', <%=Mandats[10]%>],
  ['מפלגת הגוש התנכ"י', <%=Mandats[11]%>],
  ['נעם', <%=Mandats[12]%>],
  ['האחדות העממית', <%=Mandats[13]%>],
  ['עוצמה יהודית', <%=Mandats[14]%>],
  ['ישראל ביתנו', <%=Mandats[15]%>],
  ['הליכוד', <%=Mandats[16]%>],
  ['מרצ', <%=Mandats[17]%>],
  ['מתקדמת', <%=Mandats[18]%>],
  ['כבוד ושיוויון', <%=Mandats[19]%>],
  ['כל ישראל אחים', <%=Mandats[20]%>],
  ['כחול לבן', <%=Mandats[21]%>],
  ['הפיראטים', <%=Mandats[22]%>],
  ['צדק', <%=Mandats[23]%>],
  ['צפון', <%=Mandats[24]%>],
  ['דעם', <%=Mandats[25]%>],
  ['זכויותנו בקולנו', <%=Mandats[26]%>],
  ['סדר חדש', <%=Mandats[27]%>],
  ['קמ"ה', <%=Mandats[28]%>],
  ['הימין החילוני', <%=Mandats[29]%>],
  ['שס', <%=Mandats[30]%>]


]);

  // Optional; add a title and set the width and height of the chart
  var options = {'title':'My Average Day', 'width':550, 'height':400};

  var chart = new google.visualization.PieChart(document.getElementById('piechart'));
  chart.draw(data, options);
}
</script>

<body>
    <div id="piechart">

    </div>
</body>
</html>
