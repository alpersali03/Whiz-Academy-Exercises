#include <stdio.h>
#include <stdlib.h>

// Node structure for adjacency list
struct Node {
    int vertex; // пътя на текущия ноуд
    struct Node* next; // следващ ноуд
};

// Graph structure
struct Graph {
    int numVertices; // броят на пътищата в целия граф
    struct Node** adjLists; // масив от ноудове
};

// Create a node
struct Node* createNode(int v) { // функция която създава следващия ноуд
    struct Node* newNode = malloc(sizeof(struct Node)); // създавама ноуд
    newNode->vertex = v; // създаваме новия ноуд
    newNode->next = NULL; // още не сме сетнали следващия ноуд 
    return newNode; // и връщаме новия ноуд
}

// Create a graph
struct Graph* createGraph(int vertices) {
    struct Graph* graph = malloc(sizeof(struct Graph));
    graph->numVertices = vertices;// колко пътя ще има в графа

    graph->adjLists = malloc(vertices * sizeof(struct Node*)); // казавме че ще има масив от ноудове но още няма стойност

    for (int i = 0; i < vertices; i++) { // минава от всички ноудове и ги сетвам на нулл
        graph->adjLists[i] = NULL;
    }
    
    return graph;
}

// Add edge dest - node destination
void addEdge(struct Graph* graph, int src, int dest) {// създаваме път между два ноуда
    struct Node* newNode = createNode(dest);
    newNode->next = graph->adjLists[src];
    graph->adjLists[src] = newNode;

    newNode = createNode(src);
    newNode->next = graph->adjLists[dest];
    graph->adjLists[dest] = newNode;
}

// Print the adjacency list
void printGraph(struct Graph* graph) {
    for (int v = 0; v < graph->numVertices; v++) {
        struct Node* temp = graph->adjLists[v];
        printf("\n Vertex %d\n: ", v);
        while (temp) {
            printf("%d -> ", temp->vertex);
            temp = temp->next;
        }
        printf("\n");
    }
}

int main() {
    struct Graph* graph = createGraph(5);

    addEdge(graph, 0, 1);
    addEdge(graph, 0, 2);
    addEdge(graph, 1, 2);
    addEdge(graph, 1, 3);
    addEdge(graph, 2, 4);

    printGraph(graph);

    return 0;
}
прати ми задачите д
dobre
