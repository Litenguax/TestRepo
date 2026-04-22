extends Node

@export var receiver: Node

func _ready():
	print("Hello Friend")
	if receiver and receiver.has_method("on_called"):
		receiver.on_called()
