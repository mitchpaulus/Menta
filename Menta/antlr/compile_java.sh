#!/bin/sh
java -jar "$ANTLR_JAR" ./*.g4
javac ./*.java
