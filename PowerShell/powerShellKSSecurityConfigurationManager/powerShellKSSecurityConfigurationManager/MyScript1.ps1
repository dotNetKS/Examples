
Function Execute() {
		[string] $email = [string]::Empty;
        [string] $response = $NqExt.GetContextEx("label", "MyApplication", "sub-label", "emailAddress", "val1", [ref] $email);
}

#Do not remove
Execute