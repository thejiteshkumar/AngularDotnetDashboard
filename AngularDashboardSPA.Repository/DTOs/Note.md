### This entire DTO section will be records instead of classes.


This is done as to maintain immutability of data while being transferred from controller to service and vice versa.

I didn't want controllers to change any DTO , all of the change will be done in service.
