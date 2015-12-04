/***********************************************
* CMotion Image Gallery- � Dynamic Drive DHTML code library (www.dynamicdrive.com)
* Visit http://www.dynamicDrive.com for source code
* Modified for autowidth and optional starting positions in
* http://www.dynamicdrive.com/forums/showthread.php?t=11839 by jschuer1 8/5/06
***********************************************/

//** July 4th, 14': Updated with swipe navigation in touch devices. Cleaned up HTML markup

 //1) Set width of the "neutral" area in the center of the gallery.
var restarea=6;
 //2) Set top scroll speed in pixels. Script auto creates a range from 0 to top speed.
var maxspeed=7;
 //3) Set to maximum width for gallery - must be less than the actual length of the image train.
var maxwidth=1000;
 //4) Set to 1 for left start, 0 for right, 2 for center.
var startpos=0;
 //5) Set message to show at end of gallery. Enter "" to disable message.
var endofgallerymsg='<span style="font-size: 11px;">End of Gallery</span>';

function enlargeimage(path, optWidth, optHeight){ //function to enlarge image. Change as desired.
	var actualWidth=typeof optWidth!="undefined" ? optWidth : "600px" //set 600px to default width
	var actualHeight=typeof optHeight!="undefined" ? optHeight : "500px" //set 500px to  default height
	var winattributes="width="+actualWidth+",height="+actualHeight+",resizable=yes"
	window.open(path,"", winattributes)
}

////NO NEED TO EDIT BELOW THIS LINE////////////

var iedom=document.all||document.getElementById, scrollspeed=0, movestate='', actualwidth='', cross_scroll, ns_scroll, statusdiv, loadedyes=0, lefttime, righttime;

function ontouch(el, callback){

	var touchsurface = el,
			dir,
			swipeType,
			startX,
			startY,
			distX,
			distY,
			threshold = 150,
			restraint = 100,
			allowedTime = 500,
			elapsedTime,
			startTime,
			mouseisdown = false,
			detecttouch = !!('ontouchstart' in window) || !!('ontouchstart' in document.documentElement) || !!window.ontouchstart || !!window.Touch || !!window.onmsgesturechange || (window.DocumentTouch && window.document instanceof window.DocumentTouch),
			handletouch = callback || function(evt, dir, phase, swipetype, distance){}

	touchsurface.addEventListener('touchstart', function(e){
		var touchobj = e.changedTouches[0]
		dir = 'none'
		swipeType = 'none'
		dist = 0
		startX = touchobj.pageX
		startY = touchobj.pageY
		startTime = new Date().getTime() // record time when finger first makes contact with surface
		handletouch(e, 'none', 'start', swipeType, 0) // fire callback function with params dir="none", phase="start", swipetype="none" etc
		e.preventDefault()
	
	}, false)

	touchsurface.addEventListener('touchmove', function(e){
		var touchobj = e.changedTouches[0]
		distX = touchobj.pageX - startX // get horizontal dist traveled by finger while in contact with surface
		distY = touchobj.pageY - startY // get vertical dist traveled by finger while in contact with surface
		if (Math.abs(distX) > Math.abs(distY)){ // if distance traveled horizontally is greater than vertically, consider this a horizontal movement
			dir = (distX < 0)? 'left' : 'right'
			handletouch(e, dir, 'move', swipeType, distX) // fire callback function with params dir="left|right", phase="move", swipetype="none" etc
		}
		else{ // else consider this a vertical movement
			dir = (distY < 0)? 'up' : 'down'
			handletouch(e, dir, 'move', swipeType, distY) // fire callback function with params dir="up|down", phase="move", swipetype="none" etc
		}
		e.preventDefault() // prevent scrolling when inside DIV
	}, false)

	touchsurface.addEventListener('touchend', function(e){
		var touchobj = e.changedTouches[0]
		elapsedTime = new Date().getTime() - startTime // get time elapsed
		if (elapsedTime <= allowedTime){ // first condition for awipe met
			if (Math.abs(distX) >= threshold && Math.abs(distY) <= restraint){ // 2nd condition for horizontal swipe met
				swipeType = dir // set swipeType to either "left" or "right"
			}
			else if (Math.abs(distY) >= threshold  && Math.abs(distX) <= restraint){ // 2nd condition for vertical swipe met
				swipeType = dir // set swipeType to either "top" or "down"
			}
		}
		// fire callback function with params dir="left|right|up|down", phase="end", swipetype=dir etc:
		handletouch(e, dir, 'end', swipeType, (dir =='left' || dir =='right')? distX : distY)
		e.preventDefault()
	}, false)

}

// USAGE:
/*
ontouch(el, function(evt, dir, phase, swipetype, distance){
	// evt: contains original Event object
	// dir: contains "none", "left", "right", "top", or "down"
	// phase: contains "start", "move", or "end"
	// swipetype: contains "none", "left", "right", "top", or "down"
	// distance: distance traveled either horizontally or vertically, depending on dir value
	if ( phase == 'move' && (dir =='left' || dir == 'right') )
		console.log('You are moving the finger horizontally by ' + distance)
})
*/

function ietruebody(){
	return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body;
}

function creatediv(){
	statusdiv=document.createElement("div")
	statusdiv.setAttribute("id","statusdiv")
	document.body.appendChild(statusdiv)
	statusdiv=document.getElementById("statusdiv")
	statusdiv.innerHTML=endofgallerymsg
}

function positiondiv(){
	var mainobjoffset=getposOffset(crossmain, "left"),
	menuheight=parseInt(crossmain.offsetHeight),
	mainobjoffsetH=getposOffset(crossmain, "top");
	statusdiv.style.left=mainobjoffset+(menuwidth/2)-(statusdiv.offsetWidth/2)+"px";
	statusdiv.style.top=menuheight+mainobjoffsetH+"px";
}

function showhidediv(what){
	if (endofgallerymsg!="") {
		positiondiv();
		statusdiv.style.visibility=what;
	}
}

function getposOffset(what, offsettype){
	var totaloffset=(offsettype=="left")? what.offsetLeft: what.offsetTop;
	var parentEl=what.offsetParent;
	while (parentEl!=null){
		totaloffset=(offsettype=="left")? totaloffset+parentEl.offsetLeft : totaloffset+parentEl.offsetTop;
		parentEl=parentEl.offsetParent;
	}
	return totaloffset;
}


function moveleft(){
	if (loadedyes){
		movestate="left";
		if (iedom&&parseInt(cross_scroll.style.left)>(menuwidth-actualwidth)){
			cross_scroll.style.left=parseInt(cross_scroll.style.left)-scrollspeed+"px";
			showhidediv("hidden");
		}
		else
			showhidediv("visible");
	}
	lefttime=setTimeout("moveleft()",10);
}

function moveright(){
	if (loadedyes){
		movestate="right";
	if (iedom&&parseInt(cross_scroll.style.left)<0){
		cross_scroll.style.left=parseInt(cross_scroll.style.left)+scrollspeed+"px";
		showhidediv("hidden");
	}
	else
		showhidediv("visible");
	}
	righttime=setTimeout("moveright()",10);
}

function motionengine(e){
	var mainobjoffset=getposOffset(crossmain, "left"),
	dsocx=(window.pageXOffset)? pageXOffset: ietruebody().scrollLeft,
	dsocy=(window.pageYOffset)? pageYOffset : ietruebody().scrollTop,
	curposy=window.event? event.clientX : e.clientX? e.clientX: "";
	curposy-=mainobjoffset-dsocx;
	var leftbound=(menuwidth-restarea)/2;
	var rightbound=(menuwidth+restarea)/2;
	if (curposy>rightbound){
		scrollspeed=(curposy-rightbound)/((menuwidth-restarea)/2) * maxspeed;
		clearTimeout(righttime);
		if (movestate!="left") moveleft();
	}
	else if (curposy<leftbound){
		scrollspeed=(leftbound-curposy)/((menuwidth-restarea)/2) * maxspeed;
		clearTimeout(lefttime);
		if (movestate!="right") moveright();
	}
	else
		scrollspeed=0;
}

function contains_ns6(a, b) {
	if (b!==null)
		while (b.parentNode)
			if ((b = b.parentNode) == a)
			return true;
		return false;
}

function stopmotion(e){
	if (!window.opera||(window.opera&&e.relatedTarget!==null))
	if ((window.event&&!crossmain.contains(event.toElement)) || (e && e.currentTarget && e.currentTarget!= e.relatedTarget && !contains_ns6(e.currentTarget, e.relatedTarget))){
		clearTimeout(lefttime);
		clearTimeout(righttime);
		movestate="";
	}
}

function fillup(){
	if (iedom){
		var curleft
		crossmain=document.getElementById? document.getElementById("motioncontainer1") : document.all.motioncontainer1;
		if(typeof crossmain.style.maxWidth!=='undefined')
			crossmain.style.maxWidth=maxwidth+'px';
		menuwidth=crossmain.offsetWidth;
		cross_scroll=document.getElementById? document.getElementById("motiongallery1") : document.all.motiongallery1;
		actualwidth=document.getElementById? document.getElementById("trueContainer1").offsetWidth : document.all['trueContainer1'].offsetWidth;
		if (startpos)
			cross_scroll.style.left=(menuwidth-actualwidth)/startpos+'px';
		crossmain.onmousemove=function(e){
			motionengine(e);
		}
		crossmain.onmouseout=function(e){
			stopmotion(e);
			showhidediv("hidden");
		}
	loadedyes=1
	if (endofgallerymsg!=""){
		creatediv();
		positiondiv();
	}
	if (document.body.filters)
		onresize()
	}
	ontouch(cross_scroll, function(evt, dir, phase, swipetype, distance){
		if (phase == 'start'){
			curleft = parseInt(cross_scroll.style.left)
		}
		else if (phase == 'move' && (dir =='left' || dir =='right')){
			var totaldist = distance + curleft
			if ((dir == 'right' && totaldist < 0) || (dir=='left' && totaldist > menuwidth-actualwidth )){
				cross_scroll.style.left = totaldist + 'px'

			}
		}
		else if (phase == 'end'){
			//do nothing
		}
	})
}

window.addEventListener('load', fillup)

window.addEventListener('resize', function(){
	if (typeof motioncontainer1!=='undefined'&&motioncontainer1.filters){
		motioncontainer1.style.width="0";
		motioncontainer1.style.width="";
		motioncontainer1.style.width=Math.min(motioncontainer1.offsetWidth, maxwidth)+'px';
	}
	menuwidth=crossmain.offsetWidth;
	cross_scroll.style.left=startpos? (menuwidth-actualwidth)/startpos+'px' : 0;
})

