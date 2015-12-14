/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var models = require('./index');

var util = require('util');

/**
 * @class
 * Initializes a new instance of the ProductResult class.
 * @constructor
 * @member {array} [values]
 * 
 * @member {string} [nextLink]
 * 
 */
function ProductResult() {
}

util.inherits(ProductResult, Array);

/**
 * Deserialize the instance to ProductResult schema
 *
 * @param {JSON} instance
 *
 */
ProductResult.prototype.deserialize = function (instance) {
  if (instance) {
    if (instance['value']) {
      var deserializedInstancevalue = [];
        instance['value'].forEach(function(element) {
        if (element) {
          element = new models['Product']().deserialize(element);
        }
        deserializedInstancevalue.push(element);
      });
      Array.prototype.push.apply(this, deserializedInstancevalue);
    }
    if (instance['nextLink'] !== undefined) {
      this['nextLink'] = instance.nextLink;
    }
  }

  return this;
};

module.exports = ProductResult;
