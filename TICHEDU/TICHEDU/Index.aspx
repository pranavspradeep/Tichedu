<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>
<!DOCTYPE html>
<html lang="en">
<head>
  <title>TichEdu Home</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <link rel="stylesheet" href="css/main.css" class="color-switcher-link">
  <link rel="stylesheet" href="assets/css/animate.css" type="text/css" />
  <link rel="stylesheet" href="assets/css/custom.css" type="text/css" />
  
</head>
<body>
<nav class="navbar navbar-default navbar-fixed-top">
  <div class="container">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span> 
      </button>
      <a class="navbar-brand" href="#"><img src="assets/images/logo.png" width="200px" alt="TichEdu"></a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar"> 
<!--      <ul class="nav navbar-nav  navbar-center">
        <li class="active"><a href="#">Home</a></li>
        <li><a href="#">Teacher</a></li>
        <li><a href="#">Student</a></li> 
        <li><a href="#">Parent</a></li> 
      </ul>
 -->      <ul class="nav navbar-nav  navbar-right">
			<li class="dropdown">
			  <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><span class="glyphicon glyphicon-log-in"></span> Login<span class="caret"></span></a>
			  <ul class="dropdown-menu" role="menu">
								<li><a href="login-student.aspx">Student</a></li>
								<li><a href="login-teacher.aspx">Teacher </a></li>
								<li><a href="login-parents.aspx">Parent </a></li>
			  </ul>
			</li>
			<li class="dropdown">
			  <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><span class="glyphicon glyphicon-user"></span> Sign up<span class="caret"></span></a>
			  <ul class="dropdown-menu" role="menu">
								<li><a href="register-student.aspx">Student</a></li>
								<li><a href="register-teacher.aspx"> Teacher</a></li>
								<li><a href="register-parents.aspx">Parent </a></li>
			  </ul>
			</li>
      </ul>
	  
    </div>
  </div>
</nav>




<div id="myCarousel" class="carousel slide" data-ride="carousel" style="margin-top:90px;">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner">
    <div class="item active">
      <img src="assets/images/sl-bg.jpg" width="100%">
      <div class="carousel-caption slcp">
	  	<img src="assets/images/layer1.png" class="slan" width="30%" style="float:left;">
        <h3>TichEdu</h3>
        <p>Teach one, save one<br><br><a href="register-teacher.aspx"><button type="button" class="btn" style="background-color: #e96969;">Sign up</button></a></p>
     </div>
    </div>

    <div class="item">
      <img src="assets/images/sl-bg.jpg" width="100%">
      <div class="carousel-caption slcp">
	  	<img src="assets/images/layer2.png" class="slan" width="40%" style="float:left;">
        <h3>TichEdu</h3>
        <p>Any time, Anywhere<br><br><a href="register-student.aspx"><button type="button" class="btn" style="background-color: #e96969;">Sign up</button></a></p>
     </div>
    </div>

    <div class="item">
      <img src="assets/images/sl-bg.jpg" width="100%">
      <div class="carousel-caption slcp">
	  	<img src="assets/images/layer3.png" class="slan" width="30%" style="float:left;">
        <h3>TichEdu</h3>
        <p>Save time <br><br><a href="register-parents.aspx"><button type="button" class="btn" style="background-color: #e96969;">Sign up</button></a></p>
     </div>
    </div>
	
	
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>



<!--
<section class="nwet">
	<div class="container">
		<div class="row">
			

			<div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
				<div class="nwss">
					<h3>News</h3>
					<marquee direction="up" loop="true" onMouseOver="this.stop();" onMouseOut="this.start();" height="360px">
					<ul class="nwsul">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                   <li><a href="#"><h4>News </h4> <%# Eval("News_date") %>  <strong><%# Eval("News_title") %> </strong><%# Eval("News_details") %> </a> </li>
                            </ItemTemplate>
                         

                        </asp:Repeater>



					<li><a href="#"><h4>News 1</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 1</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 2</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 3</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 4</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 5</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 6</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					<li><a href="#"><h4>News 7</h4>  <strong>dd/mm/yyy </strong>News Line Here News Line Here News Line Here News Line Here News Line Here</a> </li>
					</ul>
					</marquee>	
				</div>
			</div>
			<div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 drbg1" style=" min-height:542px; margin:auto; display:block;" >
			<h3>Events</h3>
				

			https://bootsnipp.com/snippets/featured/event-list
				<ul class="event-list ">
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <li>
						<time style="width:auto" datetime="<%# Eval("Date") %>">
							<span class="month"  ><%# Eval("Date") %> </span>
							
						</time>
						<div class="info">
							<h4 class="title"><%# Eval("Eventtitle") %></h4>
							<p class="desc"><%# Eval("Eventdetails") %> </p>
						</div>
					</li>
                        </ItemTemplate>
                    </asp:Repeater>
					

					<!--<li>
						<time datetime="2014-07-20 2000">
							<span class="day">20</span>
							<span class="month">Jan</span>
							<span class="year">2014</span>
							<span class="time">8:00 PM</span>
						</time>
						<div class="info">
							<h4 class="title">Event Title Here</h4>
							<p class="desc">Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
						</div>
					</li>

					<li>
						<time datetime="2014-07-20 2000">
							<span class="day">20</span>
							<span class="month">Jan</span>
							<span class="year">2014</span>
							<span class="time">8:00 PM</span>
						</time>
						<div class="info">
							<h4 class="title">Event Title Here</h4>
							<p class="desc">Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
						</div>
					</li>
				</ul>
			</div>
		</div>
	</div>
</section>--->


<section>
	<div class="container">
		<div class="row">
		  <div class="col-md-6">
				<img src="assets/images/ab1.png" style="width:100%">
		  </div>
		  <div class="col-md-6 vam">
				<h2>Chat Math</h2>
				<p>Join our math discussions and share your knowledge with other math students on our engaging chat platforms</p>
		  </div>
		</div>
		<div class="row">
		  <div class="col-md-6 vam">
				<h2>Monitor Student activities </h2>
				<p>Parents and teachers can see when and what students have accessed onsite as well as the progress. Once teachers has posted activities, parents get a summary with notifications of what’s new for students </p>
		  </div>
		  <div class="col-md-6">
				<img src="assets/images/ab2.png" style="width:100%">
		  </div>
		</div>
		<div class="row">
		  <div class="col-md-6">
				<img src="assets/images/ab3.png" style="width:100%">
		  </div>
		  <div class="col-md-6 vam">
				<h2>Updates </h2>
				<p>Parents, teachers and students get news updates to keep them in touch with educational innovations and changes around them</p>
		  </div>
		</div>
		<div class="row">
		  <div class="col-md-6 vam">
				<h2>Online Assessment </h2>
				<p>Assess your knowledge levels at your own time in the comfort of your own settings. Take an assessment, get graded as you complete and get corrections  </p>
		  </div>
		  <div class="col-md-6">
				<img src="assets/images/ab4.png" style="width:100%">
		  </div>
		</div>
		
		
		<div class="row">
		  <div class="col-md-6">
				<img src="assets/images/ab5.png" style="width:100%">
		  </div>
		  <div class="col-md-6 vam">
				<h2>Save time </h2>
				<p>Brings students together online and save travel time. Students can learn at their convenient time with minimal supervision</p>
		  </div>
		</div>
		<div class="row">
		  <div class="col-md-6 vam">
				<h2>Quality tutorials</h2>
				<p>Students have access to quality materials from the best tutors around the world. </p>
		  </div>
		  <div class="col-md-6">
				<img src="assets/images/ab6.png" style="width:100%">
		  </div>
		</div>
	</div>
</section>

<footer class="cra">
Designed by <a href="#">AimSoft</a>
</footee>


  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <script src="assets/js/custom.js"></script>
</body>