﻿<%@ control language="C#" autoeventwireup="true" inherits="WebService_Components_ProjectGroup, App_Web_dzlrugyb" %>
<%@ Register src="Projects.ascx" tagname="Projects" tagprefix="uc1" %>

<%if(Projects==null || Projects.Count==0){ %>
<div class="header box" style="padding-left:5px;margin-top:5px;">No project found</div>
<%} %>