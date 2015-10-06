Q1. What database models do you know?



A1. There are four types of db models:

- Hierarchical (tree)
- Network / graph
- Relational (table)
- Object-oriented 


----------
Q2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

A2. Relational Database Management Systems (RDBMS) manage data stored in tables
RDBMS systems typically implement:


- Creating / altering / deleting tables and relationships between them (database schema)
- Adding, changing, deleting, searching and retrieving of data stored in the tables
- Support for the SQL language
- Optional transaction management


----------
Q3. Define what is "table" in database terms.

A3. Tables are the basic structures within databases that are used to store data. Each database table consists of rows and columns. Each column in the database table contains similarly grouped information while each row in the database table contains associated data.


----------
Q4. Explain the difference between a primary and a foreign key.

A4. Primary key is a column in the table which uniquely identifies its rows, while the foreign key is an identifier of a record located in another table (the primary key)



----------

Q5. Explain the different kinds of relationships between tables in relational databases.

A5. Repeating data in DBs is avoided by using relationships. The relationships are:

- One-to-many - one entry in a table has a relationship with multiple entries from another table (used very often)
- Many-to-many - entries from one table have relationship with entries from another table (implemented through additional table)
- One-to-one - one entry from a table has a relationship with exactly one entry from another table (used to model inheritance between tables). The number of rows in tables must be equal


----------
Q6. When is a certain database schema normalized?

A6. Data normalization is a process in which data attributes within a data model are organized to increase the cohesion of entity types.  In other words, the goal of data normalization is to reduce and even eliminate data redundancy. The benefits of normalization are:

- Normalization produces smaller tables with smaller rows
- Searching, sorting, and creating indexes is faster, since tables are narrower, and more rows fit on a data page
- Index searching is often faster, since indexes tend to be narrower and shorter.


----------
Q7. What are database integrity constraints and when are they used?

A7. Constraints are a very important feature in a relational model. Constraints are useful because they allow a designer to specify the semantics of data in the database and constraints are the rules to enforce DBMSs to check that data satisfies the semantics.
There are several kinds of integrity constraints:

- Entity integrity - Every table requires a primary key.  The primary key, nor any part of the primary key, can contain NULL values.
- Referential integrity – a foreign key must have a matching primary key or it must be null
etc.


----------
Q8. Point out the pros and cons of using indexes in a database.

A8. Pros:

use an index for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort
As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it. 

Cons:

too index will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.


----------
Q9. What's the main purpose of the SQL language?

A9. Manipulation of relational data bases.



----------
Q10. What are transactions used for?

A10. Transactions are a sequence of db operations, which are executed as a single operation. 

Example: A bank transfer from one account into another (withdrawal + deposit)


----------
Q11. What is a NoSQL database?

A11. NoSQL databases use document-based model (non-relational)


----------
Q12. Explain the classical non-relational data models.

A12. Non-relational data models are:

- document model - consists of a set of documents
- key-value model - set of KVPs
- Hierachical key-value
- wide-column model - key-value model with schema
- object model - a set of OOP-style objects


----------
Q13. Give few examples of NoSQL databases and their pros and cons.

A13. NoSQL DBs are highly optimized for append/retrieve and have great performance and scalability.



- Redis - Ultra-fast in-memory data structures server
- MongoDB - Mature and powerful JSON-document database
- CouchDB - JSON-based document database with REST API
- Cassandra - Distributed wide-column database 