# Sinn des Projektes 
Das Projekt ist eine .NET Maui Apllikation die mithilfe des Beschleundigungssensor ermittelt ob das Handy Vertikal oder Horizontal gehalten wird.

# Beschleunigungssensor
Der Sensor ermittelt wie schnell sich das Handy bewegt bzw. wie es ausgerichtet ist. Die Position wird wiedergegeben mit drei verschiedenen werten die jeweils zwischen 1 und 0 sein können: X, Y und Z. Um also zu erkennen wie das Handy in der Hand gehalten kann durch diesen Sensor einfach zu bestimmt werden.

## Ermitteln von Vertikal/Horizontal
Wenn das Handy Vertikal gehalten wird, ist der Y Wert nahe zu 1 bzw. wenn es auf dem Kopfsteht nahe zu -1. Wenn das Handy Horizontal gehalten wird ist der X Wert nahe zu 1 wenn das Handy nach rechts gekippt wird und nahe zu -1 wenn man es nach Rechts kippt.   
