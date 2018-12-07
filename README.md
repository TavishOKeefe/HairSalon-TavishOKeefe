# _HairSalon_

#### By _**Tavish OKeefe**_

## Description

_This application allows a user to add an associates name, and assigns that associate a unique id. This application allows a user to add a client, assign that client a unique id, then pairs that client to an associate. This application allows the user to view a list of the clients and associates. This application allows the user to view an associates clients._

## Specifications
* _**Create database to store information, and test database to test information.**_
* _**Create table to hold stylist name and id.**_
* _**Create table to hold client name, id, and stylist key id.**_
* _**Create class, constructor, and properties for stylist.**_
* _**create class, constructor, and properties for client.**_
* _**Write method to get stylist name.**_
* _**Write test for get stylist name method.**_
* _**Write method to get stylist id.**_
* _**Write test for get stylist id.**_
* _**Write method to save stylist name, and assign id.**_
* _**Write method to get stylist name, and id.**_
* _**Write test to check that GetAll method returns an empty list.**_
* _**Write test to check that GetAll method returns inputed new objects.**_
* _**Write test to test save method is operational.**_
* _**Write Equals method so as to separate primary data table and test data table. (Result in GetAll and Save method tests passing).**_


## _Setup/Installation Requirements_

* _Clone repository to your desktop_
* _Open in Atom, or text and source code editor of your choosing._
* _CREATE Database tavish_okeefe._
* _CREATE TABLE `tavish_okeefe`.`stylists` ( `id` INT NOT NULL AUTO_INCREMENT , `name`VARCHAR(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE =InnoDB;_
* _CREATE TABLE `tavish_okeefe`.`clients` ( `id` INT NOT NULL AUTO_INCREMENT , `name`VARCHAR(255) NOT NULL , `stylist_id` INT NOT NULL , PRIMARY KEY (`id`)) ENGINE =InnoDB;_



## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Tavish OKeefe: okeefe.tavish@gmail.com_

## Technologies Used

* _CSharp_
* _JavaScript_
* _PHPMyAdmin_

### License

Copyright (c) 2018, _Tavish O'Keefe_  

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:  

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE._
