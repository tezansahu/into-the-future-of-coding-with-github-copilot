class Graph:
    def __init__(self):
        self.nodes = {}
    
    def add_edge(self, u, v):
        if u in self.nodes:
            self.nodes[u].append(v)
        else:
            self.nodes[u] = [v]
        if v not in self.nodes:
            self.nodes[v] = []

    def dfs(self, start, visited=None):
        if visited is None:
            visited = set()
        visited.add(start)
        print(start)
        for neighbor in self.nodes[start]:
            self.dfs(neighbor, visited)

# Example usage
graph = Graph()
graph.add_edge('A', 'B')
graph.add_edge('B', 'C')
graph.add_edge('C', 'A')

graph.dfs('A')