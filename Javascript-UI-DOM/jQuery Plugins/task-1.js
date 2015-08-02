function solve(){
  return function(selector){
    var $selectedElement = $(selector);
    var $wrapper = $('<div class="dropdown-list"></div>');
    $selectedElement.css('display', 'none');
    $selectedElement.appendTo($wrapper);

    var $current = $('<div class="current" data-value=""></div>').html('Option 1');
    $current.appendTo($wrapper);
    var $optionsContainer = $('<div class="options-container" style="position: absolute; display: none;"></div>');

    for (var i = 0; i < $selectedElement.get(0).childElementCount; i++) {
      var $dropdownItem = $('<div class="dropdown-item"></div>');
      $dropdownItem.attr('data-value', 'value-' + (i + 1));
      $dropdownItem.attr('data-index', i);
      $dropdownItem.html('Option ' + (i + 1));
      $dropdownItem.appendTo($optionsContainer);
    }

    $optionsContainer.appendTo($wrapper);
    $(document.body).append($wrapper);

    $current.on('click', function(){
      $optionsContainer.css('display', 'block');
      $(this).html('Select a value');
    });

    $optionsContainer.on('click', '.dropdown-item', function(){
      $current.html($(this).html());
      $optionsContainer.css('display', 'none');
      $selectedElement.val($(this).attr('data-value'));
    });
     return this;
  };
}

module.exports = solve;