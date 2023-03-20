## chain of responsibility for detecting sentences where a sentence is defined as at least 2 
## words separated by a single or multiple space 

building blocks 

	1. CHAIN. the sequence of handlers to be executed
		needs an interface
	2. HANDLER. contains business logic and is a piece of the chain
		business logic :
			word: 1 alphanumeric chars at least
			sentence: at least 2 words devided by whitespace 
			test cases:
				1. "mia protash " VALID 
					chain must start with charcheck

				2. "__MIA LATHOS PROTASH" NOT VALID
					chain must start with whitespacecheck
	3. 
	
	
