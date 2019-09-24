


// var x = document.getElementById("form_sample");
// var createform = document.createElement('form'); // Create New Element Form
// createform.setAttribute("action", ""); // Setting Action Attribute on Form
// createform.setAttribute("method", "post"); // Setting Method Attribute on Form
// x.appendChild(createform);

// var heading = document.createElement('h2'); // Heading of Form
// heading.innerHTML = "Contact Form ";
// createform.appendChild(heading);

// var line = document.createElement('hr'); // Giving Horizontal Row After Heading
// createform.appendChild(line);

// var linebreak = document.createElement('br');
// createform.appendChild(linebreak);

// var namelabel = document.createElement('label'); // Create Label for Name Field
// namelabel.innerHTML = "Your Name : "; // Set Field Labels
// createform.appendChild(namelabel);

// var inputelement = document.createElement('input'); // Create Input Field for Name
// inputelement.setAttribute("type", "text");
// inputelement.setAttribute("name", "dname");
// createform.appendChild(inputelement);

// var linebreak = document.createElement('br');
// createform.appendChild(linebreak);

// var emaillabel = document.createElement('label'); // Create Label for E-mail Field
// emaillabel.innerHTML = "Your Email : ";
// createform.appendChild(emaillabel);

// var emailelement = document.createElement('input'); // Create Input Field for E-mail
// emailelement.setAttribute("type", "text");
// emailelement.setAttribute("name", "demail");
// createform.appendChild(emailelement);

// var emailbreak = document.createElement('br');
// createform.appendChild(emailbreak);

// var messagelabel = document.createElement('label'); // Append Textarea
// messagelabel.innerHTML = "Your Message : ";
// createform.appendChild(messagelabel);

// var texareaelement = document.createElement('textarea');
// texareaelement.setAttribute("name", "dmessage");
// createform.appendChild(texareaelement);

// var messagebreak = document.createElement('br');
// createform.appendChild(messagebreak);

// var submitelement = document.createElement('input'); // Append Submit Button
// submitelement.setAttribute("type", "submit");
// submitelement.setAttribute("name", "dsubmit");
// submitelement.setAttribute("value", "Submit");
// createform.appendChild(submitelement);

var x=document.getElementById("form_sample");
var createform=document.createElement("form");
createform.setAttribute("method","post");
x.appendChild(createform);

var heading=document.createElement('h2');
   heading.innerHTML="form using javascript";
   createform.appendChild(heading);

   var line=document.createElement('hr');
   createform.appendChild(line);

   var linebreak = document.createElement('br');
     createform.appendChild(linebreak);

    var email=document.createElement('label');
    email.innerHTML="email id:";
    createform.appendChild(email);

var emailin=document.createElement("input");
emailin.setAttribute("type","text");
emailin.setAttribute("name","emailid");
createform.appendChild(emailin);

var emailbreak = document.createElement('br');
createform.appendChild(emailbreak);

var line=document.createElement('hr');
createform.appendChild(line);

var linebreak = document.createElement('br');
     createform.appendChild(linebreak);

 
var pass=document.createElement("label");
pass.innerHTML="password:";
createform.appendChild(pass);

var passin=document.createElement("input");
passin.setAttribute("type","text");
passin.setAttribute("name","pass");
createform.appendChild(passin);

var emailbreak = document.createElement('br');
createform.appendChild(emailbreak);

var line=document.createElement('hr');
createform.appendChild(line);

var linebreak = document.createElement('br');
     createform.appendChild(linebreak);

var messagelabel = document.createElement('label');
messagelabel.innerHTML = "Your Message : ";
createform.appendChild(messagelabel);

 var texareaelement = document.createElement('textarea');
 texareaelement.setAttribute("name", "dmessage");
 createform.appendChild(texareaelement);
 
 var emailbreak = document.createElement('br');
createform.appendChild(emailbreak);

var line=document.createElement('hr');
createform.appendChild(line);

var linebreak = document.createElement('br');
     createform.appendChild(linebreak);



var subelem=document.createElement("input");
subelem.setAttribute("type","submit");
subelem.setAttribute("name","sub");
createform.appendChild(subelem);