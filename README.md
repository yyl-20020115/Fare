NAutomaton
===================

A library that contains a DFA/NFA (finite-state automata) implementation with Unicode alphabet (UTF16) and support for the standard regular expression operations (concatenation, union, Kleene star) and a number of non-standard ones (intersection, complement, etc.). 

NAutomaton is a .NET port of the well established Java library [dk.brics.automaton](http://www.brics.dk/automaton/) with API as close as possible to the corresponding dk.brics.automaton classes.

Development environment
-----------------------

* Microsoft Visual Studio 2010
  * .NET Framework 3.5
* ReSharper 6.0 Build 6.0.2202.688
* StyleCop 4.6.3.0
* AutoFixture 2.4.1
  * xUnit.net data theories
* xUnit.net 1.8.0.1549

Design changes
--------------

* Included a .NET port of [Xeger] (http://code.google.com/p/xeger/), for generating random text from regular expressions. Xeger does [<i>not</i>] (http://code.google.com/p/xeger/wiki/XegerLimitations) support all valid Java regular expressions. The full set of what is defined here and is summarized below. Future versions might support a more complete set, in case of popular demand.
* Implemented object equality.
* Many getters and setters have been replaced by .NET properties.
* Many foreach loops have been converted to LINQ-expressions.
 
NAutomaton in use
-----------------
