/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
  return function (selector) {
    var element;
    if(typeof selector == 'string') {
      element = document.getElementById(selector);
    }
    else {
      element = selector;
    }

    if(element == null) {
      throw new Error('This element does not exist');
    }

    var buttonElements = element.getElementsByClassName('button');

      function changeContentElements() {
        var buttonClicked = this;
        var nextElement = buttonClicked.nextSibling;

          if(nextElement.className == 'content') {
            if(nextElement.style.display != 'none') {
              nextElement.style.display = 'none';
              buttonClicked.innerHTML = 'show';
            }
            else {
              nextElement.style.display = '';
              buttonClicked.innerHTML = 'hide';
            }
          }
      }

    for (var i = 0; i < buttonElements.length; i++) {
        buttonElements[i].innerHTML = 'hide';
        buttonElements[i].addEventListener('click', changeContentElements, false);
      }
  };
}

module.exports = solve;