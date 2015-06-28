/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	var domElement = (function () {
		var domElement = {
			init: function(type) {
				this.type = type;
				this.content = '';
				this.attributes = {};
				this.children = [];
				this.parent = null;

				return this;
			},
			appendChild: function(child) {
				if(typeof child !== 'string') {
					child.parent = this;
				}
				this.children.push(child);
				return this;
			},
			addAttribute: function(name, value) {
				if(!this._type || !validateAttributeName(name)) {
					throw new Error('Attribute name is not valid');
				}
				this.attributes[name] = value;
				return this;
			},
			removeAttribute: function(attribute) {
				if(this.attributes[attribute] === undefined) {
					throw new Error('No such attribute to remove');
				}
				delete this.attributes[attribute];
				return this;
			},

      		get innerHTML() {
				var html = generateHTML(this);
				return html;
      		}

		};
		// properties definition start

		Object.defineProperties(domElement, {
			'type': {
				get: function() {
					return this._type;
				},
				set: function(value) {
					if(!validateType(value)) {
						throw new Error('Type is not valid');
					}
					this._type = value;
					return this;
				}
			},

			'content' : {
				set: function(value) {
					if(this._children === undefined) {
						this._content = value;
					}
					return this;
				},
				get: function() {
					return this._content;
				}
			}
		});

		// properties definition end

		// extra functions start

		function validateType(value) {
			if(typeof value === 'string' && value !== '' && /^[a-z0-9]+$/i.test(value)){
				return true;
			}
			return false;
		}

		function validateAttributeName(attribute) {
			if(attribute !== '' && /^[a-z0-9\-]+$/i.test(attribute)) {
				return true;
			}
			return false;
		}

		function outputAttributes(element) {
			var attributeString = '',
				i,
				resultArray = [],
				indexSorted;

			if(element.attributes) {
				for(prop in element.attributes) {
					resultArray.push([prop, element.attributes[prop]]);
				}
			}

			resultArray = resultArray.sort();

			resultArray.forEach(function(property) {
				attributeString += ' ' + property[0] + '="' + property[1] + '"';
			});

			return attributeString;
		}

		function outputChildren(element) {
			var childrenString = '',
				j;
			if(element.children.length > 0) {
				for(j = 0; j < element.children.length; j++) {
					childrenString = '<' + element.type + '>' + element.content + '</' + element.type + '>';
				}
			}
			return childrenString;
		}

		function generateHTML(tag) {
			var	result = '',
				innerContent = '';

			if(tag.children.length > 0) {
				tag.children.forEach(function(item){
					typeof item === "string" ? innerContent += item : innerContent += item.innerHTML;
				});
				result = '<' + tag.type + outputAttributes(tag) + '>' + innerContent + '</' + tag.type + '>';
			}
			else {
				result = '<' + tag.type + outputAttributes(tag) + '>'+ tag.content + '</' + tag.type + '>';
			}

			return result;
		}

		// extra functions end

		return domElement;
	} ());

	return domElement;
}

module.exports = solve;
