# Sinn des Projektes 
Das Projekt ist eine .NET Maui Applikation, die mithilfe des Beschleunigungssensors ermittelt, ob das Handy vertikal oder horizontal gehalten wird.

# Beschleunigungssensor
Der Sensor ermittelt, wie schnell sich das Handy bewegt bzw. wie es ausgerichtet ist. Die Position wird wiedergegeben mit drei verschiedenen Werten, die jeweils zwischen 1 und 0 sein können: X, Y und Z. Um also zu erkennen, wie das Handy in der Hand gehalten, kann durch diesen Sensor einfach zu bestimmt werden.

## Ermitteln von Vertikal/Horizontal
Wenn das Handy vertikal gehalten wird, ist der Y Wert nahe zu 1 bzw. wenn es auf dem Kopfsteht nahe zu -1. Wenn das Handy horizontal gehalten wird, ist der X Wert nahe zu 1, wenn das Handy nach rechts gekippt wird und nahe zu -1, wenn man es nach rechts kippt.   
