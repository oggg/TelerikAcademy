/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neighter `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {

      var args = Array.prototype.slice.call(arguments);

      if(typeof element !== 'string' && !element.nodeName) {
        throw new Error('The provided first parameter is neither string or existing DOM element');
      }

      if(typeof element !== 'string' && element === null) {
        throw new Error('The provided id does not select anything');
      }

      if(args.length < 2) {
          throw new Error('One of the parameters is missing');
      }

      //if(typeof element !== 'string') {
      //    throw new TypeError('The first element should be a string');
      //}

      if(!Array.isArray(contents)) {
          throw  new TypeError('The second element must be an array');
      }

      for (var i = 0; i < contents.length; i++) {
          if(typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
              throw new Error('Type mismatch of contents');
          }
      }

      var selectedElement = undefined;

      if(typeof element === 'string') {
        selectedElement = document.getElementById(element);
      }
    else { // if (element.nodeName){
        selectedElement = element;
      }

        while(selectedElement.firstChild) {
            selectedElement.removeChild(selectedElement.firstChild);
        }

        var fragment = document.createDocumentFragment();
        var div = document.createElement('div');

        for (var i = 0; i < contents.length; i++) {
          var clonedDiv = div.cloneNode(true);
          clonedDiv.innerHTML = contents[i];
          fragment.appendChild(clonedDiv);
        }
      selectedElement.appendChild(fragment);
  };
};