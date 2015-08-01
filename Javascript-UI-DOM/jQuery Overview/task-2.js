/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    if(typeof selector !== 'string' && !(selector instanceof jQuery)) {
      throw new Error("The provided value is not meeting the requirements");
    }
    if($(selector).get(0) == null) {
      throw new Error("Selector does not select anything");
    }
    $('.button').text('hide').on('click', changeContentElements);

    var $collection = $('.button, .content');

    function changeContentElements() {
      var $buttonClicked = $(this);
      var indexOfCLicked = $collection.index($buttonClicked);
      var nextElement = $collection[indexOfCLicked + 1];
      var $nextElement = $(nextElement);
      var clName = $nextElement.attr('class');
      var display = $nextElement.css( 'display' );
      if(clName === 'content') {
        display = $nextElement.css( 'display' );
        if(display !== 'none') {
          $buttonClicked.html('show');
          $nextElement.css('display', 'none');
          }
        else {
          $buttonClicked.html('hide');
          $nextElement.css('display', '');
        }
      }
    }
  };
};

module.exports = solve;