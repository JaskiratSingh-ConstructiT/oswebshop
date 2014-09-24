this.m_navstyler = function(){
	var m_nav = document.getElementById("m_nav")
	if(m_nav){
      
		this.listItem = function(li){
			if(li.getElementsByTagName("ul").length > 0){
				var ul = li.getElementsByTagName("ul")[0];			
				var span = document.createElement("span");
				
				if (ul.style.display == "block") {
				span.className = "expanded";
				} else {
				span.className = "collapsed";
				ul.style.display = "none";
				}

				span.onclick = function(){
					ul.style.display = (ul.style.display == "none") ? "block" : "none"; 
					this.className = (ul.style.display == "none") ? "collapsed" : "expanded";
				};
				/* Just change the color of the triangle */
				span.onmouseover = function(){
					if (span.className == "collapsed") {
					   span.className = "collapsedHover";
					} else if (span.className == "expanded") {
					   span.className = "expandedHover";
					};
				};
				/* Just change the color of the triangle back */
				span.onmouseout = function(){
					if (span.className == "collapsedHover") {
					   span.className = "collapsed";
					} else if (span.className == "expandedHover") {
					   span.className = "expanded";
					};
				};
				li.appendChild(span);

			};
			/* end ul controls */
		
		};
		/* end listItem function */

		var items = m_nav.getElementsByTagName("li");
		for(var i=0;i<items.length;i++){
			listItem(items[i]);
		};
		
		/* end items */

	};
	/* end if(m_nav) */
};
/* end m_navstyler */

window.onload = m_navstyler;
