function checkKeyPress(e) {
    console.log(e.keyCode); var xsplit = document.activeElement.id.split('x');

    var ysplit = xsplit[1].split('y')[0]; console.log(xsplit[0],ysplit);

    if(e.keyCode != 38 && e.keyCode != 39 && e.keyCode != 40 && e.keyCode != 37)
    {console.log('easy')
    return;
        }
    if(e.keyCode == 38) {
        console.log((xsplit[0] - 1) + 'x' + ysplit + 'y');
        document.getElementById((xsplit[0]-1) + 'x'+ysplit+'y').focus();
    }
        else if(e.keyCode == 37)
        {
        console.log(xsplit[0] + 'x' + (ysplit - 1) + 'y');  document.getElementById(xsplit[0] + 'x'+(ysplit -1)+'y').focus();
}
           else if (e.keyCode == 40)
{
        console.log((parseInt(xsplit[0] + 1), 10) + 'x' + ysplit + 'y');
    document.getElementById((parseInt(xsplit[0], 10) + 1) + 'x' + ysplit + 'y').focus();
}
else if (e.keyCode == 39)
{
        console.log((xsplit[0] + 'x') + (parseInt(ysplit, 10) + 1) + 'y'); document.getElementById((xsplit[0] + 'x') + (parseInt(ysplit, 10) + 1 + 'y')).focus();
}


                 }
