if mvn -q clean compile dependency:copy-dependencies ; then
	java -cp target/classes/:target/dependency/* app.Program $*
fi


